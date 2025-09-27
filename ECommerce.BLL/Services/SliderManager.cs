using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.BLL.Services
{
    public class SliderManager : CrudManager<Slider, SliderViewModel, CreateSliderViewModel, UpdateSliderViewModel>, ISliderService
    {
        private readonly ISliderRepository _repository;
        private readonly IMapper _mapper;

        public SliderManager(ISliderRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<SliderViewModel>> GetSlidersByIdAsync(int id)
        {
            var sliders = await _repository.GetSliderByIdAsync(id);
            return _mapper.Map<List<SliderViewModel>>(sliders);
        }
    }
}