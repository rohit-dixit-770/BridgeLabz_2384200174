function isPrime(num) {
    if (num < 2) return false;
    for (let i = 2; i * i <= num; i++) {
        if (num % i === 0) return false;
    }
    return true;
}

function getPalindrome(num) {
    let palindrome = num.toString().split('').reverse().join('');
    return parseInt(palindrome);
}

function checkPrimeAndPalindrome(num) {
    if (!isPrime(num)) {
        console.log(`${num} is NOT a prime number`);
        return;
    }

    let palindrome = getPalindrome(num);
    console.log(`${num} is a Prime Number`);

    if (isPrime(palindrome)) {
        console.log(`The Palindrome ${palindrome} is also Prime`);
    } else {
        console.log(`The Palindrome ${palindrome} is NOT Prime`);
    }
}

console.log("Enter a number:");

process.stdin.on('data', function (input) {
    let num = parseInt(input);

    checkPrimeAndPalindrome(num);
    process.exit();
});
