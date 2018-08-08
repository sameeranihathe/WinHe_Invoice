using DataHadelar;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class ProductLogic
    {
        ProductData prodata = new ProductData();
        //Getdata From DataHadelaer to Datalogic
        public List<ProductDto> GetProduct()
        {
            List<ProductDto> returnlist = new List<ProductDto>();

            returnlist = this.prodata.GetData();


            return returnlist;
        }

        //Search Dta From DataHadaler to Datalogic
        public List<ProductDto> GetSearchProduct(String SearchText)
        {
            List<ProductDto> returnlist = new List<ProductDto>();

            returnlist = this.prodata.GetSearchData(SearchText);


            return returnlist;
        }

        //Add Dta From DataHadaler to Datalogic
        public bool AddProduct(ProductDto AddData)
        {
            return this.prodata.AddProductData(AddData);
        }

        //Delete From DataHadaler to Datalogic
        public bool DeleteProduct(int ProId)
        {
            return this.prodata.DeleteProductData(ProId);
        }
        //Update From DataHadaler to Datalogic
        public void UppdateLogicData(ProductDto objs)
        {

            prodata.UpdateproductData(objs);
        }
    }
}
