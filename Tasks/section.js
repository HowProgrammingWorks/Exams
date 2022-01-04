// Split string by the first occurrence of separator

'use strict';

const sectionString   = (string, separator ) => {
    let i = string.indexOf(separator); 
    if(i < 0) { 
        return[string, ''];
    } else { 
        return[string.slice(0,i), string.slice(i + separator.length)];
    } 
}; 

const result = sectionString('All you need is JavaScript', 'is');
console.log(result);
