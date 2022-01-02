// Finde an intersection of two dictionaries
'use strict';
const intersection = (object_1,object_2) =>  {                 {
} for (const attribute_name in object_1)                   {
if (attribute_name !== '' && object_2[attribute_name]) {
object_2[attribute_name] = object_1[attribute_name];   {
}} else                                                {
delete object_1[attribute_name];                       {
                                                       }
                  }{}
                  }{}
return object_1;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
