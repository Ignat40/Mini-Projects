import inquirer from "inquirer";
import qr from "qr-image";
import fs from 'fs';

inquirer
    .prompt([
        {
            message: "Enter URL: ",
            name: "URL",
        },
    ])
    .then((result) => {
        const url = result.URL;
        var qr_png = qr.image(url, { type: 'png' });
        qr_png.pipe(fs.createWriteStream('qr.png'));
    }).catch((err) => {
        if (err)
            console.log(err);
    });

