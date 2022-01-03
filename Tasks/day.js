// Get day number

const days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']

const parseDay= (day)=>{
  let i; for(i=0; i<days.length; i++){
  if(day.startsWith(days[i].toLowerCase())){return i +1};};return -1;
};

const result = parseDay('friday')
console.log(result)

