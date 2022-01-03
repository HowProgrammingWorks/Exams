// Replace substring with newstr
'use strict';
const replace = (string, subString, newString) => {
  if (subString  ===  '') return string;
  let copyString = string;
  let result = '';
  while (true) {
    const index = copyString.indexOf(subString);
    if (index  ===  -1)  return result + copyString;
    const start  =  copyString.substring(0,  index);
    copyString  =  copyString.substring(index + subString.length,  copyString.length);
    result += start + newString;
  }
};

const result1 = replace('Hello <username> and bye!',  '<username>',  'Marcus');
const result2 = replace('<name> welcome!We are happy to see you <name>!',  '<name>',  'Marcus');
const result3 = replace('<<name>>',  '<name>',  'Marcus');

console.dir({ result1,  result2,  result3 });
