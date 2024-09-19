using Lab11.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab11.Models
{
    class PageManager
    {
        public Page CurrentPage { get; set; }

        public PageManager() { }

        public PageManager(Page currentPage)
        {
            CurrentPage = currentPage;
        }

        public void SetCurrentPage(Page page)
        {
            CurrentPage = page;
        }
    }
}
