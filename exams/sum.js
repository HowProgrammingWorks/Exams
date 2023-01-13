const sum = (array = []) => {
    let total = 0;
    for (let number of array){
        if(typeof number === 'number'){
            total += number;
        }
    }
    return total;

};
require('../Tests/sum.js')(sum);