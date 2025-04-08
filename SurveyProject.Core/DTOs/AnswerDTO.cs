using System.Text.Json;
using SurveyProject.Core.DTOs;

public class AnswerDTO
{
    public int Id { get; set; }
    public SurveyDTO Survey { get; set; }

    public static void SaveAnswersToJson(List<AnswerDTO> answers, string filePath)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true, ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve // Для обработки циклических ссылок
        };

        string json = JsonSerializer.Serialize(answers, options);
        File.WriteAllText(filePath, json);
    }

    public static List<AnswerDTO> LoadAnswersFromJson(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<AnswerDTO>>(json);
    }
}
