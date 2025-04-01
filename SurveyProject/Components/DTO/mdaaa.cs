
// это придумал жпт

// Для регистрации/авторизации
public class UserAuthDto
{
    public string Email { get; set; }
    public string Password { get; set; }
}

// Для отображения информации о пользователе
public class UserDto
{
    public int Id { get; set; }
    public string Email { get; set; }
    public bool IsCreator { get; set; }
}

// Для создания опроса
public class CreateSurveyDto
{
    public string Title { get; set; }
    public List<QuestionDto> Questions { get; set; }
}

// Для отображения опроса
public class SurveyDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int CreatorId { get; set; }
    public List<QuestionDto> Questions { get; set; }
}

public class QuestionDto
{
    public string Text { get; set; }
    public List<string> Options { get; set; } // Варианты ответов
}

// Для отправки ответов
public class SurveyResponseDto
{
    public int SurveyId { get; set; }
    public List<AnswerDto> Answers { get; set; }
}

public class AnswerDto
{
    public int QuestionId { get; set; }
    public List<string> SelectedOptions { get; set; } // Для вариантов
    public string TextAnswer { get; set; } // Для текстового ответа
}

// Для просмотра результатов
public class SurveyResultDto
{
    public SurveyDto Survey { get; set; }
    public List<UserResponseDto> UserResponses { get; set; }
}

public class UserResponseDto
{
    public UserDto User { get; set; }
    public List<AnswerDto> Answers { get; set; }
    public DateTime CompletionDate { get; set; }
}