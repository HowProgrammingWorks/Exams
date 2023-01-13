const sum = (s = []) => {
    let total = 0;
    for (let i of s){
        if(typeof i === 'number'){
            total += i;
        }
    }
    return total;

};
require('../Tests/sum.js')(sum);