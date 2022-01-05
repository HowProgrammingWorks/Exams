// Get day number

let day = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']

const getDayNumber = function(text){
  for(let i=0;i<day.length;i++){
    if(text != null && text.toLowerCase().startsWith(day[i].toLowerCase()))
    {return i +1};};
};

const result = getDayNumber('friday')
console.log(result) 
