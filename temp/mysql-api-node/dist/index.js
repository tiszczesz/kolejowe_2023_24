"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const Repository_js_1 = require("./Repository.js");
const app = (0, express_1.default)();
const port = 8080;
app.get("/api/products", async (req, res) => {
    const result = await (0, Repository_js_1.GetAll)();
    console.log(result);
    res.json(result);
});
app.post("/api/products", async (req, res) => {
    const product = await req.body;
    console.log(product);
    const result = await (0, Repository_js_1.InsertProduct)(product);
    console.log("Wstawiono: ", result);
});
app.listen(port, () => {
    console.log(`Serwer działa na porcie ${port}`);
});
