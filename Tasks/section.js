// Split string by the first occurrence of separator

'use strict';

const sectionString   = (string, separator ) => {
    let finalArr = [];
    let i = string.indexOf(separator); 
    if(i < 0) {
        finalArr = [string, ''];
        return finalArr;
    } else {
        const beforeSeparator = string.slice(0, i);
        const afterSeparator = string.slice(i + separator.length); 
        finalArr = [beforeSeparator, afterSeparator];
        return finalArr;
    } 
}; 

const result = sectionString('All you need is JavaScript', 'is');
console.log(result);
