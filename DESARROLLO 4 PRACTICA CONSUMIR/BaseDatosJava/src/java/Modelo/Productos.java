/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Modelo;

/**
 *
 * @author Itos
 */
public class Productos {
    
    private int ProductID;
    private String ProductName;
    private int CategoryID;
    private String QuantityPerUnit;
    private float UnitPrice;
    private int UnitsInStock;
    private int Discontinued;

    /**
     * @return the ProductID
     */
    public int getProductID() {
        return ProductID;
    }

    /**
     * @param ProductID the ProductID to set
     */
    public void setProductID(int ProductID) {
        this.ProductID = ProductID;
    }

    /**
     * @return the ProductName
     */
    public String getProductName() {
        return ProductName;
    }

    /**
     * @param ProductName the ProductName to set
     */
    public void setProductName(String ProductName) {
        this.ProductName = ProductName;
    }

    /**
     * @return the CategoryID
     */
    public int getCategoryID() {
        return CategoryID;
    }

    /**
     * @param CategoryID the CategoryID to set
     */
    public void setCategoryID(int CategoryID) {
        this.CategoryID = CategoryID;
    }

    /**
     * @return the QuantityPerUnit
     */
    public String getQuantityPerUnit() {
        return QuantityPerUnit;
    }

    /**
     * @param QuantityPerUnit the QuantityPerUnit to set
     */
    public void setQuantityPerUnit(String QuantityPerUnit) {
        this.QuantityPerUnit = QuantityPerUnit;
    }

    /**
     * @return the UnitPrice
     */
    public float getUnitPrice() {
        return UnitPrice;
    }

    /**
     * @param UnitPrice the UnitPrice to set
     */
    public void setUnitPrice(float UnitPrice) {
        this.UnitPrice = UnitPrice;
    }

    /**
     * @return the UnitsInStock
     */
    public int getUnitsInStock() {
        return UnitsInStock;
    }

    /**
     * @param UnitsInStock the UnitsInStock to set
     */
    public void setUnitsInStock(int UnitsInStock) {
        this.UnitsInStock = UnitsInStock;
    }

    /**
     * @return the Discontinued
     */
    public int getDiscontinued() {
        return Discontinued;
    }

    /**
     * @param Discontinued the Discontinued to set
     */
    public void setDiscontinued(int Discontinued) {
        this.Discontinued = Discontinued;
    }
    
    public Productos(int ProductID, String ProductName, int CategoryID, String QuantityPerUnit, float UnitPrice, int UnitsInStock, int Discontinued)
    {
        this.ProductID =ProductID;
        this.ProductName = ProductName; 
        this.CategoryID = CategoryID;
        this.QuantityPerUnit = QuantityPerUnit;
        this.UnitPrice = UnitPrice;
        this.UnitsInStock = UnitsInStock;
        this.Discontinued = Discontinued;
    }
    
      public Productos(String ProductName, int CategoryID, String QuantityPerUnit, float UnitPrice, int UnitsInStock, int Discontinued)
    {
        this.ProductID =ProductID;
        this.ProductName = ProductName; 
        this.CategoryID = CategoryID;
        this.QuantityPerUnit = QuantityPerUnit;
        this.UnitPrice = UnitPrice;
        this.UnitsInStock = UnitsInStock;
        this.Discontinued = Discontinued;
    }
    
    
}
