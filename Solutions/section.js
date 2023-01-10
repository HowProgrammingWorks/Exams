// Split string into array by the first occurrence of separator
'use strict';

const sectionString = (string, separator) => {
    let i = string.indexOf(separator);
     if (i === -1 || separator === '') {
       return [string, ''];
     } else {
     return [string.slice(0, i), string.slice(i + separator.length)];
     }
   };
   require('../Tests/section.js')(sectionString);
