// Finde an intersection of two dictionaries

const intersection = (obj_1,obj_2) => {
keys_1 = Object.keys(obj_1);                    {
} for (name of keys_1)                   {
if (name !== '' && obj_2[name]) {
obj_2[name] = obj_1[name];   {
}} else                                                {
delete obj_1[name];                       {
                                                       }
                  }{}
                  }{}
return obj_1;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
