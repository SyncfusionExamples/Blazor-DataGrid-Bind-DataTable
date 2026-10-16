# Blazor DataGrid Bind DataTable

## Overview

This sample demonstrates how to bind a `System.Data.DataTable` directly to a Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid). Instead of using a strongly typed collection, the example creates and populates a `DataTable` and assigns it as the Grid's data source so that the Grid can automatically generate and display rows from tabular data. This approach is useful when data is obtained from legacy components, database APIs, reporting systems, or other sources that expose results as `DataTable` objects rather than typed business models.

## Key Features

- Uses the Syncfusion Blazor DataGrid (`SfGrid`) component to render tabular data.
- Demonstrates binding a `System.Data.DataTable` instance directly to the Grid data source.
- Shows how rows and columns stored in a `DataTable` can be displayed without creating a custom model class.
- Demonstrates runtime population of `DataTable` records before assigning the data source to the Grid.
- Provides a simple reference implementation for displaying dynamically generated tabular data in Syncfusion Blazor applications.
- Focuses specifically on DataTable-based binding rather than remote services, adaptors, or strongly typed collections.

## Prerequisites

* Visual Studio 2022 or Visual Studio Code

## How to Run the Project

**Visual Studio 2022**

1. Checkout this repository to a local folder.
2. Open the solution available in the `DataTableS` project folder using Visual Studio 2022.
3. Restore NuGet packages by building the project.
4. Run the application.
5. Navigate to the page containing the Syncfusion Blazor DataGrid sample.
6. Observe the Grid rendering records retrieved from the configured `System.Data.DataTable` data source.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the project directory.

```bash
dotnet restore
dotnet run
```

## Project Structure

- `DataTableS/` — contains the Blazor sample project demonstrating DataTable-to-Grid binding.
- `DataTableS/Pages/` — contains the Razor page that hosts the Syncfusion Blazor DataGrid implementation and binds the `DataTable` instance.
- `DataTableS/Data/` — contains supporting data-generation logic used to create and populate the `DataTable` data source.
- `DataTableS/Program.cs` — configures the Blazor application and registers required services used by the sample.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For DataGrid data-binding documentation, see: https://help.syncfusion.com/grid-sdk/blazor/data-grid/data-binding/local-data#datatable-binding

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
