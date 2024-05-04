using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementsystem.Models
{
    public class paginated_list<T> : List<T>
    {
        public int PageIndex { get; private  set; }
        public int Totalpage { get;  set; }
        public paginated_list(List<T> iteam,int count,int pageIndex, int pageSize) 
        {
            PageIndex = pageIndex;
            Totalpage = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(iteam);
    
        }
        public bool PreviousPage
        {
            get
            {
                return(this.PageIndex > 1);
            }
        }
        public bool NextPage
        {
            get
            {
                return (PageIndex < Totalpage);
            }
        }
        public static async Task<paginated_list<T>> CreateAsync(IQueryable<T> source,int pageIndex,int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex -1) * pageSize).Take(pageSize).ToListAsync();
            return new paginated_list<T>(items, count, pageIndex, pageSize);
        }
    }
}
