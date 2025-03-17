let money = 100;
let bets = 0;
let wins = 0;

while (money > 0 && money < 200) {
    bets++;
    let betResult = Math.floor(Math.random()*10) < 5 ; 

    if (betResult) {
        money++;
        wins++;
    } else {
        money--;
    }
}

console.log(`Total Bets: ${bets}, Total Wins: ${wins}`);
console.log(money === 200 ? "You reached Rs 200" : "You went broke!");
