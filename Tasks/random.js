// Generate random integer value in given range

const randomInteger = (min, max) => {
if ( max === undefined ){
    max = min;
     return Math.floor(Math.randomInteger() * (max + 1));
    } else {
    return min + Math.floor(Math.randomInteger() * (max - min + 1));
};
};

const result = randomInteger(1, 9);
console.log(result);
