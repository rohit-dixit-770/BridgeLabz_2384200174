let globalVar = "global"; 

function show() {
    let localVar = "local";
    console.log(globalVar); 
    console.log(localVar); 
}

show();
console.log(globalVar); 
// console.log(localVar); Error (localVar is not defined outside the function)
