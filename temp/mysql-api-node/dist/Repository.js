"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.InsertProduct = exports.GetAll = void 0;
const promise_1 = __importDefault(require("mysql2/promise"));
const GetAll = async () => {
    const connection = await promise_1.default.createConnection({
        host: 'localhost',
        user: 'root',
        database: '4pr_api_products',
    });
    const [results, fields] = await connection.query('SELECT * FROM `Products` ');
    console.log(results); // results contains rows returned by server
    console.log(fields); // fields contains extra meta data about results, if available
    connection.end();
    return results;
};
exports.GetAll = GetAll;
const InsertProduct = async (product) => {
    const connection = await promise_1.default.createConnection({
        host: 'localhost',
        user: 'root',
        database: '4pr_api_products',
    });
    try {
        const [results] = await connection.query('INSERT INTO Products (name, price,RealizeDate) VALUES (?, ?, ?)', [product.name, product.price, product.RealizeDate.toLocaleDateString()]);
    }
    catch (err) {
        console.log(err);
    }
};
exports.InsertProduct = InsertProduct;
// A simple SELECT query
