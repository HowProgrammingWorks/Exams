// Get month number
'use script';

const month = (s) => 
    {   for (let i = 0; i <months.length; i++)
        if (s.startswith(months[i]))
         return i + 1

};

const month = ['jan','feb','mar','apr','may','jun','jul','aug','sep','oct','nov','dec'];
const result = month (s, 'february')
console.log (result)
