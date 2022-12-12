using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Core.Application.Interfaces.Services
{
    public interface IGenericService<Entity, ViewModel, SaveViewModel>
        where Entity : class
        where ViewModel : class
        where SaveViewModel : class
    {
        Task<SaveViewModel> Add(SaveViewModel saveVM);
        Task<bool> Update(SaveViewModel saveVM, int id);
        Task<List<ViewModel>> GetAllViewModel();
        Task<List<ViewModel>> GetAllViewModelRelation(List<string> properties);
        Task<SaveViewModel> GetByIdSaveViewModel(int id);
        Task<ViewModel> GetByIdViewModel(int id);
        Task<bool> Delete(int id);
    }
}
