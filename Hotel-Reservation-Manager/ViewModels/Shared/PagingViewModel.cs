<<<<<<< HEAD
﻿namespace Hotel_Reservation_Manager.ViewModels.Shared
{
    using System;
=======
﻿using System;

namespace Hotel_Reservation_Manager.ViewModels.Shared
{
>>>>>>> 9b615d978ebcefaac978178e5eda4c713a65289f
    public class PagingViewModel
    {
        public PagingViewModel(int itemsPerPage = 10, string action = "Index")
        {
            this.ItemsPerPage = itemsPerPage;
            this.Action = action;
            this.Page = 1;
        }

        public int Page { get; set; }

        public bool HasPreviousPage => this.Page > 1;

        public int PreviousPageNumber => this.Page - 1;

        public bool HasNextPage => this.Page < this.PagesCount;

        public int NextPageNumber => this.Page + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.ElementsCount / this.ItemsPerPage);

        public int ElementsCount { get; set; }

        public int ItemsPerPage { get; set; }

        public string Action { get; set; }
<<<<<<< HEAD
    }
}
=======

    }
}
>>>>>>> 9b615d978ebcefaac978178e5eda4c713a65289f
