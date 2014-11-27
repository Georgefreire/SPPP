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
public class Categorias {
  private int CategoryID ;
  private String CategoryName;
  private String Description;

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
     * @return the CategoryName
     */
    public String getCategoryName() {
        return CategoryName;
    }

    /**
     * @param CategoryName the CategoryName to set
     */
    public void setCategoryName(String CategoryName) {
        this.CategoryName = CategoryName;
    }

    /**
     * @return the Description
     */
    public String getDescription() {
        return Description;
    }

    /**
     * @param Description the Description to set
     */
    public void setDescription(String Description) {
        this.Description = Description;
    }
     public Categorias(int CategoryID,String CategoryName, String Description )
     {
        this.CategoryID = CategoryID  ;
        this.CategoryName = CategoryName;
        this.Description =  Description;
     }
     
      public Categorias(String CategoryName, String Description )
     {
        
        this.CategoryName = CategoryName;
        this.Description =  Description;
     }
}
