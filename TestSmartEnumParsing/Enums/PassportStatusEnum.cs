namespace PL.Dadata.Contracts.Enums{

public enum PassportStatusEnum
{
    /// <summary>
    /// Действующий паспорт
    /// </summary>
    Active = 0,

    /// <summary>
    /// Неправильный формат серии или номера
    /// </summary>
    Incorrect = 1,

    /// <summary>
    /// Исходное значение пустое
    /// </summary>
    Empty = 2,

    /// <summary>
    /// Недействительный паспорт
    /// </summary>
    Inactive = 10
}}