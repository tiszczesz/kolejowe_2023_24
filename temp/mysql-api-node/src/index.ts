import express from 'express';
import { GetAll, InsertProduct } from './Repository.js';

const app = express();

const port = 8080;

app.get('/api/products',async (req,res)=>{
    const result = await GetAll();
    console.log(result);
    
     res.json(result);
});
app.post('/api/products',async (req,res)=>{
    const product= req.body
    const result = await InsertProduct(product)
    console.log("Wstawiono: ",result)
})

app.listen(port,()=>{
    console.log(`Serwer działa na porcie ${port}`);
});