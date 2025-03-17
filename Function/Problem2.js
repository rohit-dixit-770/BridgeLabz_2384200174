function isPalindrome(num) {
    let str = num.toString();
    return str === str.split('').reverse().join('');
}

console.log("Enter number to check Palindrome: ")
process.stdin.on('data', function(input){
    let num = parseInt(input); 
    
    console.log(isPalindrome(num)); 
    process.exit();
});

