using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Workflows",
    Author = "The Orchard Team",
    Website = "http://orchardproject.net",
    Version = "2.0.0",
    Description = "The Workflows module provides tools and APIs to create custom workflows",
    Dependencies = "OrchardCore.Liquid, OrchardCore.Scripting",
    Category = "Workflows"
)]

[assembly: Feature(
    Id = "OrchardCore.Workflows",
    Name = "Workflows",
    Description = "The Workflows module provides tools and APIs to create custom workflows",
    Dependencies = "OrchardCore.Liquid, OrchardCore.Scripting",
    Category = "Workflows"
)]

[assembly: Feature(
    Id = "OrchardCore.Workflows.Http",
    Name = "HTTP Workflows Activities",
    Description = "Provides HTTP-related services and activities.",
    Dependencies = "OrchardCore.Workflows",
    Category = "Workflows"
)]

[assembly: Feature(
    Id = "OrchardCore.Workflows.Email",
    Name = "Email Workflow Activities",
    Description = "Provides email-related services and activities.",
    Dependencies = "OrchardCore.Workflows",
    Category = "Workflows"
)]

[assembly: Feature(
    Id = "OrchardCore.Workflows.Timers",
    Name = "Timer Workflow Activities",
    Description = "Provides timer-based services and activities.",
    Dependencies = "OrchardCore.Workflows",
    Category = "Workflows"
)]