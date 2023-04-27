namespace Application.Contracts.Infrastructure;

public interface ICsvExporter
{
    //TODO: replace [object] with your [DT] that you want return
    byte[] ExportEventsToCsv(List<object> eventExportDtos);
}
