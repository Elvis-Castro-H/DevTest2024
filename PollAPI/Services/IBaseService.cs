namespace PollAPI.Services;

public interface IBaseService<TOutputDto, TInputDto, TId>
{
    Task<ICollection<TOutputDto>> GetAll();
    Task<TOutputDto> Create(TInputDto dto);
}