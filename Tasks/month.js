// Get month number
const months = ['jan','feb','mar','apr','may','jun','jul','aug','sep','oct','nov','dec']
const parseMonth = (month) => {
  for (let i = 0; i < months.length; i++){
  if (month.toLowerCase().startsWith(months[i]))
   return i + 1;
   }
};
const result = parseMonth('february')
console.log(result)
