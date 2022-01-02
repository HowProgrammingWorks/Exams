// Replace substring with newstr
'use strict';

const replace = (str, substr, newstr) => {
  if (substr === '') {
    return str;
  }
  let res = '';
  while (str.indexOf(substr) !== -1) {
   const _index = str.indexOf( substr) ; 
   const start = str.substring(0,_index);
   str = str.substring(_index+substr.length,str.length)
   res += start + newstr
  }
  return res + str;
};

const result = replace('Hello <username> and bye!', '<username>', 'Marcus')
console.log(result)
