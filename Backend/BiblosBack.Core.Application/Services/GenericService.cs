using AutoMapper;
using BiblosBack.Core.Application.Interfaces.Repositories;
using BiblosBack.Core.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.Services
{
    public class GenericService<Entity, ViewModel, SaveViewModel> : IGenericService<Entity, ViewModel, SaveViewModel>
        where Entity : class
        where ViewModel : class
        where SaveViewModel : class
    {
        private readonly IGenericRepository<Entity> _repo;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public virtual async Task<SaveViewModel> Add(SaveViewModel saveVM)
        {
            Entity entity = _mapper.Map<Entity>(saveVM);
            entity = await _repo.AddAsync(entity);
            SaveViewModel vm = _mapper.Map<SaveViewModel>(entity);

            return vm;
        }

        public virtual async Task<ViewModel> Update(SaveViewModel saveVM, int id)
        {
            Entity entity = _mapper.Map<Entity>(saveVM);
            var vm = await _repo.UpdateAsync(entity, id);
            return _mapper.Map<ViewModel>(vm);
        }

        public virtual async Task<List<ViewModel>> GetAllViewModel()
        {
            var entities = await _repo.GetAllAsync();
            return _mapper.Map<List<ViewModel>>(entities);
        }

        public virtual async Task<SaveViewModel> GetByIdSaveViewModel(int id)
        {
            Entity entity = await _repo.GetByIdAsync(id);
            SaveViewModel saveVM = _mapper.Map<SaveViewModel>(entity);
            return saveVM;
        }

        public virtual async Task<ViewModel> GetByIdViewModel(int id)
        {
            Entity entity = await _repo.GetByIdAsync(id);
            ViewModel vm = _mapper.Map<ViewModel>(entity);
            return vm;
        }

        public virtual async Task Delete(int id)
        {
            Entity entity = await _repo.GetByIdAsync(id);
            await _repo.DeleteAsync(entity);
        }
    }
}
