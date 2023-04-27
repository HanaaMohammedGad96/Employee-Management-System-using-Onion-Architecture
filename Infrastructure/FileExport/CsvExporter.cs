using Application.Contracts.Infrastructure;
using CsvHelper;

namespace Infrastructure.FileExport;

public class CsvExporter// : ICsvExporter
{
    //public byte[] ExportEventsToCsv(List<object> eventExportDtos)
    //{
    //    using var memoryStream = new MemoryStream();
    //    using (var streamWriter = new StreamWriter(memoryStream))
    //    {
    //        using var csvWriter = new CsvWriter(streamWriter);
    //        csvWriter.WriteRecords(eventExportDtos);
    //    }

    //    return memoryStream.ToArray();
    //}
}
