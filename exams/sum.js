const sum = (array = []) => {
    let total = 0;
    for (let value of array){
        if(typeof value === 'number'){
            total += value;
        }
    }
    return total;

};
require('../Tests/sum.js')(sum);
