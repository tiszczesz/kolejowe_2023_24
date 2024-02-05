import mysql from 'mysql2/promise';
import { Product } from './Product.js';

export const GetAll = async () => {
  const connection = await mysql.createConnection({
    host: 'localhost',
    user: 'root',
    database: '4pr_api_products',
  });
  const [results, fields] = await connection.query(
    'SELECT * FROM `Products` '
  );

  console.log(results); // results contains rows returned by server
  console.log(fields); // fields contains extra meta data about results, if available
  connection.end();
  return results;
}
export const InsertProduct = async (product: Product) => {
  const connection = await mysql.createConnection({
    host: 'localhost',
    user: 'root',
    database: '4pr_api_products',
  });
  try {
    const [results] = await connection.query(
      'INSERT INTO Products (name, price,RealizeDate) VALUES (?, ?, ?)',
      [product.name, product.price, product.RealizeDate.toLocaleDateString()]);
      

  } catch (err) {
    console.log(err);
  }
}



// A simple SELECT query
