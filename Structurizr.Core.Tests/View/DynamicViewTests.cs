﻿using System;
using System.Linq;
using Xunit;

namespace Structurizr.Core.Tests
{
    
    public class DynamicViewTests : AbstractTestBase
    {

        private Person person;
        private SoftwareSystem softwareSystemA;
        private Container containerA1;
        private Container containerA2;
        private Container containerA3;
        private Component componentA1;
        private Component componentA2;

        private SoftwareSystem softwareSystemB;
        private Container containerB1;
        private Component componentB1;

        private Relationship relationship;

        public DynamicViewTests()
        {
            person = Model.AddPerson("Person", "");
            softwareSystemA = Model.AddSoftwareSystem("Software System A", "");
            containerA1 = softwareSystemA.AddContainer("Container A1", "", "");
            componentA1 = containerA1.AddComponent("Component A1", "");
            containerA2 = softwareSystemA.AddContainer("Container A2", "", "");
            componentA2 = containerA2.AddComponent("Component A2", "");
            containerA3 = softwareSystemA.AddContainer("Container A3", "", "");
            relationship = containerA1.Uses(containerA2, "uses");

            softwareSystemB = Model.AddSoftwareSystem("Software System B", "");
            containerB1 = softwareSystemB.AddContainer("Container B1", "", "");
        }

        [Fact]
        public void Test_Add_ThrowsAnException_WhenTheScopeOfTheDynamicViewIsASoftwareSystemButAContainerInAnotherSoftwareSystemIsAdded()
        {
            try
            {
                DynamicView dynamicView = Workspace.Views.CreateDynamicView(softwareSystemA, "key", "Description");
                dynamicView.Add(containerB1, containerA1);
                throw new TestFailedException();
            }
            catch (Exception e)
            {
                Assert.Equal("Only containers that reside inside Software System A can be added to this view.", e.Message);
            }
        }

        [Fact]
        public void Test_Add_ThrowsAnException_WhenTheScopeOfTheDynamicViewIsASoftwareSystemButAComponentIsAdded()
        {
            try
            {
                DynamicView dynamicView = Workspace.Views.CreateDynamicView(softwareSystemA, "key", "Description");
                dynamicView.Add(componentA1, containerA1);
                throw new TestFailedException();
            }
            catch (Exception e)
            {
                Assert.Equal("Components can't be added to a dynamic view when the scope is a software system.", e.Message);
            }
        }

        [Fact]
        public void Test_Add_ThrowsAnException_WhenTheScopeOfTheDynamicViewIsASoftwareSystemAndTheSameSoftwareSystemIsAdded()
        {
            try
            {
                DynamicView dynamicView = Workspace.Views.CreateDynamicView(softwareSystemA, "key", "Description");
                dynamicView.Add(softwareSystemA, containerA1);
                throw new TestFailedException();
            }
            catch (Exception e)
            {
                Assert.Equal("Software System A is already the scope of this view and cannot be added to it.", e.Message);
            }
        }

        [Fact]
        public void Test_Add_ThrowsAnException_WhenTheScopeOfTheDynamicViewIsAContainerAndTheSameContainerIsAdded()
        {
            try
            {
                DynamicView dynamicView = Workspace.Views.CreateDynamicView(containerA1, "key", "Description");
                dynamicView.Add(containerA1, containerA2);
                throw new TestFailedException();
            }
            catch (Exception e)
            {
                Assert.Equal("Container A1 is already the scope of this view and cannot be added to it.", e.Message);
            }
        }

        [Fact]
        public void Test_Add_ThrowsAnException_WhenTheScopeOfTheDynamicViewIsAContainerAndTheParentSoftwareSystemIsAdded()
        {
            try
            {
                DynamicView dynamicView = Workspace.Views.CreateDynamicView(containerA1, "key", "Description");
                dynamicView.Add(softwareSystemA, containerA2);
                throw new TestFailedException();
            }
            catch (Exception e)
            {
                Assert.Equal("Software System A is already the scope of this view and cannot be added to it.", e.Message);
            }
        }

        [Fact]
        public void Test_Add_ThrowsAnException_WhenTheScopeOfTheDynamicViewIsAContainerAndAContainerInAnotherSoftwareSystemIsAdded()
        {
            try
            {
                DynamicView dynamicView = Workspace.Views.CreateDynamicView(containerA1, "key", "Description");
                dynamicView.Add(containerB1, containerA2);
                throw new TestFailedException();
            }
            catch (Exception e)
            {
                Assert.Equal("Only containers that reside inside Software System A can be added to this view.", e.Message);
            }
        }

        [Fact]
        public void Test_Add_ThrowsAnException_WhenTheScopeOfTheDynamicViewIsAContainerAndAComponentInAnotherContainerIsAdded()
        {
            try
            {
                DynamicView dynamicView = Workspace.Views.CreateDynamicView(containerA1, "key", "Description");
                dynamicView.Add(componentA2, containerA2);
                throw new TestFailedException();
            }
            catch (Exception e)
            {
                Assert.Equal("Only components that reside inside Container A1 can be added to this view.", e.Message);
            }
        }

        [Fact]
        public void Test_Add_AddsTheSourceAndDestinationElements_WhenARelationshipBetweenThemExists()
        {
            DynamicView dynamicView = Workspace.Views.CreateDynamicView(softwareSystemA, "key", "Description");
            dynamicView.Add(containerA1, containerA2);
            Assert.Equal(2, dynamicView.Elements.Count);
        }

        [Fact]
        public void Test_Add_ThrowsAnException_WhenThereIsNoRelationshipBetweenTheSourceAndDestinationElements()
        {
            DynamicView dynamicView = Workspace.Views.CreateDynamicView(softwareSystemA, "key", "Description");
            Assert.Throws<ArgumentException>(() =>
                dynamicView.Add(containerA1, containerA3)
            );
        }

        [Fact]
        public void Test_AddRelationshipDirectly()
        {
            DynamicView dynamicView = Workspace.Views.CreateDynamicView(softwareSystemA, "key", "Description");
            dynamicView.Add(relationship);
            Assert.Equal(2, dynamicView.Elements.Count);
        }

        [Fact]
        public void Test_Add_AddsTheSourceAndDestinationElements_WhenARelationshipBetweenThemExistsAndTheDestinationIsAnExternalSoftwareSystem()
        {
            DynamicView dynamicView = Workspace.Views.CreateDynamicView(softwareSystemA, "key", "Description");
            containerA2.Uses(softwareSystemB, "", "");
            dynamicView.Add(containerA2, softwareSystemB);
            Assert.Equal(2, dynamicView.Elements.Count);
        }

        [Fact]
        public void Test_NormalSequence()
        {
            Workspace = new Workspace("Name", "Description");
            Model = Workspace.Model;

            SoftwareSystem softwareSystem = Model.AddSoftwareSystem("Software System", "Description");
            Container container1 = softwareSystem.AddContainer("Container 1", "Description", "Technology");
            Container container2 = softwareSystem.AddContainer("Container 2", "Description", "Technology");
            Container container3 = softwareSystem.AddContainer("Container 3", "Description", "Technology");

            container1.Uses(container2, "Uses");
            container1.Uses(container3, "Uses");

            DynamicView view = Workspace.Views.CreateDynamicView(softwareSystem, "key", "Description");

            view.Add(container1, container2);
            view.Add(container1, container3);

            Assert.Same(container2, view.Relationships.First(rv => rv.Order.Equals("1")).Relationship.Destination);
            Assert.Same(container3, view.Relationships.First(rv => rv.Order.Equals("2")).Relationship.Destination);
        }

        [Fact]
        public void Test_ParallelSequence()
        {
            Workspace = new Workspace("Name", "Description");
            Model = Workspace.Model;
            SoftwareSystem softwareSystem = Model.AddSoftwareSystem("Name", "Description");
            Person user = Model.AddPerson("User", "Description");
            Container microservice1 = softwareSystem.AddContainer("Microservice 1", "", "");
            Container database1 = softwareSystem.AddContainer("Database 1", "", "");
            Container microservice2 = softwareSystem.AddContainer("Microservice 2", "", "");
            Container database2 = softwareSystem.AddContainer("Database 2", "", "");
            Container microservice3 = softwareSystem.AddContainer("Microservice 3", "", "");
            Container database3 = softwareSystem.AddContainer("Database 3", "", "");
            Container messageBus = softwareSystem.AddContainer("Message Bus", "", "");

            user.Uses(microservice1, "Updates using");
            microservice1.Delivers(user, "Sends updates to");

            microservice1.Uses(database1, "Stores data in");
            microservice1.Uses(messageBus, "Sends messages to");
            microservice1.Uses(messageBus, "Sends messages to");

            messageBus.Uses(microservice2, "Sends messages to");
            messageBus.Uses(microservice3, "Sends messages to");

            microservice2.Uses(database2, "Stores data in");
            microservice3.Uses(database3, "Stores data in");

            DynamicView view = Workspace.Views.CreateDynamicView(softwareSystem, "key", "Description");

            view.Add(user, "1", microservice1);
            view.Add(microservice1, "2", database1);
            view.Add(microservice1, "3", messageBus);

            view.StartParallelSequence();
            view.Add(messageBus, "4", microservice2);
            view.Add(microservice2, "5", database2);
            view.EndParallelSequence();

            view.StartParallelSequence();
            view.Add(messageBus, "4", microservice3);
            view.Add(microservice3, "5", database3);
            view.EndParallelSequence();

            view.Add(microservice1, "5", database1);

            Assert.Equal(1, view.Relationships.Count(r=>r.Order.Equals("1")));
            Assert.Equal(1, view.Relationships.Count(r => r.Order.Equals("2")));
            Assert.Equal(1, view.Relationships.Count(r => r.Order.Equals("3")));
            Assert.Equal(3, view.Relationships.Count(r => r.Order.Equals("4")));
            Assert.Equal(2, view.Relationships.Count(r => r.Order.Equals("5")));
        }

    }
}
