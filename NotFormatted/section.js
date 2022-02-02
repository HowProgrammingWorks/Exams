// Split string into array by the first occurrence of separator

SectionString   = (s, t ) => {  ; 
i = s.indexOf(t) 
if(i < 0|| t == ''){ 
return[s, ''] 
} 
else 
{ 
return[s.slice(0,i),s.slice(i+t.length)] 
} 
} 

require('../Tests/section.js')(SectionString);
