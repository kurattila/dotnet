﻿using System.IO;

namespace Structurizr.Documentation
{
    
    /// <summary>
    /// An implementation of the arc42 documentation template (http://arc42.org)
    /// consisting of the following sections:
    ///  - Introduction and Goals (1)
    ///  - Constraints (2)
    ///  - Context and Scope (2)
    ///  - Solution Strategy (3)
    ///  - Building Block View (3)
    ///  - Runtime View (3)
    ///  - Deployment View (3)
    ///  - Crosscutting Concepts (3)
    ///  - Architectural Decisions (3)
    ///  - Quality Requirements (2)
    ///  - Risks and Technical Debt (4)
    ///  - Glossary (5)
    ///
    /// The number in parentheses () represents the grouping, which is simply used to colour code
    /// section navigation buttons when rendered.
    /// </summary>
    public class Arc42DocumentationTemplate : DocumentationTemplate
    {
        
        public Arc42DocumentationTemplate(Workspace workspace) : base(workspace)
        {
        }
        
        /// <summary>
        /// Adds an "Introduction and Goals" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddIntroductionAndGoalsSection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Introduction and Goals", Group1, files);
        }

        /// <summary>
        /// Adds an "Introduction and Goals" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddIntroductionAndGoalsSection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Introduction and Goals", Group1, format, content);
        }
        
        /// <summary>
        /// Adds a "Constraints" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddConstraintsSection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Constraints", Group2, files);
        }

        /// <summary>
        /// Adds a "Constraints" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddConstraintsSection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Constraints", Group2, format, content);
        }
        
        /// <summary>
        /// Adds a "Context and Scope" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddContextAndScopeSection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Context and Scope", Group2, files);
        }

        /// <summary>
        /// Adds a "Context and Scope" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddContextAndScopeSection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Context and Scope", Group2, format, content);
        }
        
        /// <summary>
        /// Adds a "Solution Strategy" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddSolutionStrategySection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Solution Strategy", Group3, files);
        }

        /// <summary>
        /// Adds a "Solution Strategy" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddSolutionStrategySection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Solution Strategy", Group3, format, content);
        }
        
        /// <summary>
        /// Adds a "Building Block View" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddBuildingBlockViewSection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Building Block View", Group3, files);
        }

        /// <summary>
        /// Adds a "Building Block View" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddBuildingBlockViewSection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Building Block View", Group3, format, content);
        }
        
        /// <summary>
        /// Adds a "Runtime View" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddRuntimeViewSection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Runtime View", Group3, files);
        }

        /// <summary>
        /// Adds a "Runtime View" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddRuntimeViewSection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Runtime View", Group3, format, content);
        }
        
        /// <summary>
        /// Adds a "Deployment View" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddDeploymentViewSection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Deployment View", Group3, files);
        }

        /// <summary>
        /// Adds a "Deployment View" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddDeploymentViewSection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Deployment View", Group3, format, content);
        }
        
        /// <summary>
        /// Adds a "Crosscutting Concepts" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddCrosscuttingConceptsSection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Crosscutting Concepts", Group3, files);
        }

        /// <summary>
        /// Adds a "Crosscutting Concepts" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddCrosscuttingConceptsSection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Crosscutting Concepts", Group3, format, content);
        }
        
        /// <summary>
        /// Adds an "Architectural Decisions" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddArchitecturalDecisionsSection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Architectural Decisions", Group3, files);
        }

        /// <summary>
        /// Adds an "Architectural Decisions" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddArchitecturalDecisionsSection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Architectural Decisions", Group3, format, content);
        }
        
        /// <summary>
        /// Adds a "Quality Requirements" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddQualityRequirementsSection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Quality Requirements", Group2, files);
        }

        /// <summary>
        /// Adds a "Quality Requirements" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddQualityRequirementsSection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Quality Requirements", Group2, format, content);
        }
        
        /// <summary>
        /// Adds a "Risks and Technical Debt" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddRisksAndTechnicalDebtSection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Risks and Technical Debt", Group4, files);
        }

        /// <summary>
        /// Adds a "Risks and Technical Debt" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddRisksAndTechnicalDebtSection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Risks and Technical Debt", Group4, format, content);
        }
        
        /// <summary>
        /// Adds a "Glossary" section relating to a SoftwareSystem from a file.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="files">one or more FileSystemInfo objects that point to the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddGlossarySection(SoftwareSystem softwareSystem, params FileSystemInfo[] files)
        {
            return AddSection(softwareSystem, "Glossary", Group5, files);
        }

        /// <summary>
        /// Adds a "Glossary" section relating to a SoftwareSystem.
        /// </summary>
        /// <param name="softwareSystem">the SoftwareSystem the documentation relates to</param>
        /// <param name="format">the format of the documentation content</param>
        /// <param name="content">a string containing the documentation content</param>
        /// <returns>a documentation Section</returns>
        public Section AddGlossarySection(SoftwareSystem softwareSystem, Format format, string content)
        {
            return AddSection(softwareSystem, "Glossary", Group5, format, content);
        }
        
    }
    
}