using System.Collections.Generic;

namespace moviebrowsingconsoleapp.IModel
{
    public interface IMenu
    {
        IMenu GetSuper();
        bool SetSuper(IMenu menu);
        List<IMenu> GetBraches();

        bool AddBranch(IMenu menu);

        bool SetBranches(List<IMenu> branchMenus);

        string GetDescriptor();

        string SetDescriptor(string descriptor);
    }
}