using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHadelar
{
    //GetData in Product Database
    public class ProductData
    {

        public List<ProductDto> GetData()
        {
            List<ProductDto> productlist = new List<ProductDto>();

            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {

                    List<ProductDetail> list = (from recodes in context.ProductDetails select recodes).ToList();

                    foreach (ProductDetail item in list)
                    {
                        ProductDto obj = new ProductDto();

                        obj.ProductId = item.Product_Id;
                        obj.ProductName = item.Product_Name;
                        obj.ProductDescription = item.Product_Description;
                        obj.PurchesePrice = item.Purchase_Price;
                        obj.SellingPrice = item.Selling_Price;
                        obj.Quantity = item.Quantity;

                        productlist.Add(obj);
                    }




                }

            }
            catch (Exception ex)
            {

            }


            return productlist;
        }
//Search Data From Product Database

        public List<ProductDto> GetSearchData(String SearchData)
        {
            List<ProductDto> productlist = new List<ProductDto>();

            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {

                    List<ProductDetail> list = (from recodes in context.ProductDetails where (recodes.Product_Name.Contains(SearchData))select recodes).ToList();

                    foreach (ProductDetail item in list)
                    {
                        ProductDto obj = new ProductDto();

                        obj.ProductId = item.Product_Id;
                        obj.ProductName = item.Product_Name;
                        obj.ProductDescription = item.Product_Description;
                        obj.PurchesePrice = item.Purchase_Price;
                        obj.SellingPrice = item.Selling_Price;
                        obj.Quantity = item.Quantity;

                        productlist.Add(obj);
                    }




                }

            }
            catch (Exception ex)
            {

            }


            return productlist;
        }
// Add data to Database
        public bool AddProductData(ProductDto Add)
        {
            bool isSaved = false;

            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {

                    ProductDetail ProDetails = new ProductDetail();
                    ProDetails.Product_Name = Add.ProductName;
                    ProDetails.Product_Description = Add.ProductDescription;
                    ProDetails.Purchase_Price = Add.PurchesePrice;
                    ProDetails.Selling_Price = Add.PurchesePrice;
                    ProDetails.Quantity = Add.Quantity;

                    context.ProductDetails.Add(ProDetails);

                    context.SaveChanges();
                    
              
              }

            }
            catch (Exception ex)
            {


            }


            return isSaved;


        }
        // delete data from database
        public bool DeleteProductData(int ProductIds)
        {
            bool isSaved = false;

            try
            {
                using (WinheProjectEntities context = new WinheProjectEntities())
                {

                    ProductDetail deleteProducts = (from recode in context.ProductDetails where recode.Product_Id == ProductIds select recode).FirstOrDefault();

                    context.ProductDetails.Remove(deleteProducts);

                    context.SaveChanges();
             }

            }
            catch (Exception ex)
            {


            }


            return isSaved;

        }
//Upddate data from database
        public void UpdateproductData(ProductDto uppdate)
        {
            


            try
            {

                using (WinheProjectEntities context = new WinheProjectEntities())
                {

                    ProductDetail UppdateProducts = (from recode in context.ProductDetails where recode.Product_Id ==uppdate.ProductId select recode).FirstOrDefault();
                   
                   
                    UppdateProducts.Product_Name = uppdate.ProductName;
                    UppdateProducts.Product_Description = uppdate.ProductDescription;
                    UppdateProducts.Purchase_Price = uppdate.PurchesePrice;
                    UppdateProducts.Selling_Price = uppdate.SellingPrice;
                    UppdateProducts.Quantity = uppdate.Quantity;

                    context.Entry(UppdateProducts).State = System.Data.EntityState.Modified;

                    context.SaveChanges();


             }

            }
            catch (Exception ex) { 
            
            
            
            
            }
         


        }
    }
}
