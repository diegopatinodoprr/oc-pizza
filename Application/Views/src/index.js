import express from "express";
import * as config from "./config";

// Init express
const app = express();
app.use(express.static('./dist'));
app.get("/", function (req, res) {
  res.send("Bientot de recettes sur  : " + req.connection.localAddress);
});

app.listen(3000, function () {
  console.log('Example app listening on port 3000!')
})