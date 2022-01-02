// Replace substring with newstr
'use strict';

const replace = (str, substr, newstr) => {
  if (substr === '') {
    return str;
  }
  res = ''
  do {
   const _index = str.indexOf( substr) ; 
   if (_index === -1) { return res + src }else{
   const start = str.substring(0,_index);
   str = str.substring(_index+substr.length,str.length)
   res += start + newstr
 }} while (true);  };

const result = replace('Hello <username> and bye!', '<username>', 'Marcus')
console.log(result)
