// Split string by the first occurrence of separator

'use strict';

const SectionString   = (s, t ) => {
let i = s.indexOf(t); 
if(i < 0){ 
return[s, ''];
} 
else 
{ 
return[s.slice(0,i),s.slice(i+t.length)];
} 
} 

const result = SectionString('All you need is JavaScript', 'is');
console.log(result);
