// Split array into two parts
'use strict';

const splitArray = (index, array) => {
    const firstArray = array.slice(0, index);
    const secondArray = array.slice(index, array.length);
    return [firstArray, secondArray];
};

const result = splitArray(5, ['a', 'b', 'c', 'd', 'e']);
console.log(result);
