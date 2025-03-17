const args = process.argv.slice(2);
let day = parseInt(args[0]);
let month = parseInt(args[1]);
let result = false;
if (month === 3 && day >= 20 && day <= 31) {
    result = true;
}
else if (month === 4 && day >= 1 && day <= 30) {
    result = true;
}
else if (month === 5 && day >= 1 && day <= 31) {
    result = true;
} 
else if (month === 6 && day >=1 && day <= 20 ) {
    result = true;
}

console.log(result);


