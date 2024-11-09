using AutoMapper;
using PollAPI.Models;
using PollAPI.Repositories;

namespace PollAPI.Services;

public abstract class BaseService<T, TOutputDto, TInputDto, TId> : IBaseService<TOutputDto, TInputDto, TId> where T : BaseEntity<TId>
{
    private readonly IBaseRepository<T, TId> _repository;
    protected readonly IMapper _mapper;
    
    public BaseService(IBaseRepository<T, TId> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<ICollection<TOutputDto>> GetAll()
    {
        var response = await _repository.GetAll();
        return _mapper.Map<ICollection<TOutputDto>>(response);
    }

    public async Task<TOutputDto> Create(TInputDto dto)
    {
        var entity = _mapper.Map<T>(dto);
        var response = await _repository.Create(entity);
        return _mapper.Map<TOutputDto>(response);
    }
}