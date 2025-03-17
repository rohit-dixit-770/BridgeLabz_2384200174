if (true) {
    var x = 10;  
    let y = 20;  
    const z = 30;
    console.log(x, y, z); 
}

console.log(x); 
// console.log(y);  Error (y is block-scoped)
// console.log(z);  Error (z is block-scoped)
