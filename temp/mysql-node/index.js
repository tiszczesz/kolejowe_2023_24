import { createConnection } from 'mysql';

const connection = createConnection({
    host:'localhost',
    user:'root',
    password:null,
    database:'pszczesz_4ti_cw1'
});

connection.connect((err)=>{
    if(err){
        console.log('Error connection: '+err.message);
        return
    }
    console.log('Połączono');
})
const queryString = 'SELECT * FROM products';
connection.query(queryString ,( err,result,fields) => {
    if(err){
        console.log("Error: "+err.message);
        return;
    }
    console.log(result);
    console.log(fields);
});
connection.end((err)=>{
    if(err){
        console.log(err.message);
        return;
    }
    console.log('Zamknieto połączenie.....');
})