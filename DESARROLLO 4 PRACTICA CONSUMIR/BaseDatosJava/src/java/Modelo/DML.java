/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Modelo;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.List;
import Modelo.Conexion.*;
import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Collection;
import java.util.Iterator;
import java.util.ListIterator;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.jws.WebService;
import javax.jws.WebMethod;


/**
 *
 * @author Itos
 */
@WebService
public class DML {
    @WebMethod
   public  List<Categorias> SelectCategorias()
   { 
      List<Categorias> categoria = null;
      Categorias c;
       Conexion conexion = new Conexion();
       Connection con = conexion.getCn();
       String sql = "Select CategoryID, CategoryName,Description from Categories";
        try {
            Statement st = con.createStatement();
            ResultSet rs =  st.executeQuery(sql);
            
            while(rs.next()){
                Integer id =rs.getInt("CategoryID");
		String CategoryName = rs.getString("CategoryName");
		String Description = rs.getString("Description");
		c = new Categorias(id,CategoryName,Description);
                if (categoria==null) {
				categoria = new Vector<Categorias>();
			}
                categoria.add(c);
            }
        } catch (SQLException ex) {
            Logger.getLogger(DML.class.getName()).log(Level.SEVERE, null, ex);
        }
        return categoria ;
       
   }
   
   @WebMethod
    public  List<Productos> SelectProductos(int CategoryID)
   { 
      List<Productos> producto = null;
      Productos c;
       Conexion conexion = new Conexion();
       Connection con = conexion.getCn();
       String sql = "SELECT  [ProductID]\n" +
                    "      ,[ProductName]\n" +
                    "      ,[QuantityPerUnit]\n" +
                    "      ,[UnitPrice]\n" +
                    "      ,[UnitsInStock]\n" +
                    "      ,[Discontinued]\n" +
                    "  FROM [Northwind].[dbo].[Products] where CategoryID= " +CategoryID+"";
        try {
            Statement st = con.createStatement();
            ResultSet rs =  st.executeQuery(sql);
            
            while(rs.next()){
                Integer id =rs.getInt("ProductID");
		String ProductName = rs.getString("ProductName");
                String QuantityPerUnit = rs.getString("QuantityPerUnit");
                Float UnitPrice = rs.getFloat("UnitPrice");
                Integer  UnitsInStock = rs.getInt("UnitsInStock");
                Integer Discontinued = rs.getInt("Discontinued");

		c = new Productos(id,ProductName,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,Discontinued);
                if (producto==null) {
				producto = new Vector<Productos>();
			}
                producto.add(c);
            }
        } catch (SQLException ex) {
            Logger.getLogger(DML.class.getName()).log(Level.SEVERE, null, ex);
        }
        return producto ;
       
   }
   
    public int deleteCategorias(int CategoryID) throws Exception {
            Conexion conexion = new Conexion();
            Connection con = conexion.getCn();
            String sql = "DELETE FROM Categories  " +
                           "WHERE CategoryID ="+CategoryID;
            
		PreparedStatement pst = con.prepareStatement(sql);
                //pst.setInt(1, CategoryID);
		
		int res = pst.executeUpdate();
   
		
		return res;
	}
    
     public int deleteProductos(int ProductID) {
            Conexion conexion = new Conexion();
            Connection con = conexion.getCn();
            int res =0;
            String sql = "DELETE FROM Products WHERE ProductID = "+ProductID+"";
            		
        try {
            PreparedStatement pst = con.prepareStatement(sql);
            res = pst.executeUpdate();	
		
        } catch (SQLException ex) {
            Logger.getLogger(DML.class.getName()).log(Level.SEVERE, null, ex);
        }
		return res;
	}
    
    @WebMethod
    public boolean InsertarCategorias(String CategoryName, String Description)
    {
        boolean rep = false;
        Conexion conectar = new Conexion();
        Connection con = conectar.getCn();
         String sql =  "Insert Into Categories (CategoryName, Description)" +
                            "VALUES (?,?)";
        try {
            PreparedStatement pst = con.prepareStatement(sql);
            pst.setString(1,CategoryName );
            pst.setString(2, Description);
            int n = pst.executeUpdate();
            
            if(n>0)
            {
              rep= true;
            }
            
        } catch (SQLException ex) {
            Logger.getLogger(DML.class.getName()).log(Level.SEVERE, null, ex);
        }
         
         return rep;
    }
    
    
    @WebMethod
    public boolean InsertarProductos(String ProductName,int CategoryID, String QuantityPerUnit)
    {
        boolean rep = false;
        Conexion conectar = new Conexion();
        Connection con = conectar.getCn();
         String sql =  "Insert Into Products (ProductName,  CategoryID, QuantityPerUnit)" +
                            "VALUES (?,?,?)";
        try {
            PreparedStatement pst = con.prepareStatement(sql);
            pst.setString(1,ProductName );
            pst.setInt(2, CategoryID);
            pst.setString(3, QuantityPerUnit);
            int n = pst.executeUpdate();
            
            if(n>0)
            {
              rep= true;
            }
            
        } catch (SQLException ex) {
            Logger.getLogger(DML.class.getName()).log(Level.SEVERE, null, ex);
        }
         
         return rep;
    }
 
    @WebMethod
   public boolean UpdateCategorias(String CategoriaName, String Description, int CategoryID )
   {
       boolean rep = false;
       Conexion conexion = new Conexion();
       Connection con = conexion.getCn();
        String sql =  "UPDATE Categories SET CategoryName = ?, Description = ? WHERE CategoryID = "+ CategoryID+"" ;
                            
        try {
            PreparedStatement pst = con.prepareStatement(sql);
            pst.setString(1,CategoriaName );
            pst.setString(2, Description);
            int n = pst.executeUpdate();
            
            if(n>0)
            {
              rep= true;
            }
            
        } catch (SQLException ex) {
            Logger.getLogger(DML.class.getName()).log(Level.SEVERE, null, ex);
        }
         
         return rep;
       
   }
}