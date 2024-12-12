import axios from 'axios'
import { Fragment, useEffect, useState } from 'react'
import { Container, Header, List } from 'semantic-ui-react'
import NavBar from './Navbar'
import UserDashboard from '../../fetaures/UserDashboard'
function App() {
  const [data, setdata] = useState<any[]>([]);
  const [selectedData, setselectedData] = useState(undefined);
  const [editMode, setEditMode] = useState(false);

 useEffect(()=>{
  axios.get("http://localhost:5053/First").then(res=>{
    setdata(res.data)
  })
 },[])
function handleSelectedAdtivity(id:string) {
  console.log(data.find((x:any)=>x.id === id));
  setselectedData(data.find((x:any)=>x.id === id));
  
}
function handleFormOpen(id?:string){
  id ? handleSelectedAdtivity(id) : handleCancelSelectedAdtivity();
  setEditMode(true);
}
function handleFormClose() {
  setEditMode(false);  
}
function handleCreateOrEditActivity(activity:any) {
  activity.id ? setdata([...data.filter(x=>x.id !== activity.id),activity])
  :setdata([...data,activity]);
  setEditMode(false);
  setselectedData(activity);  
}
function handleCancelSelectedAdtivity() {
  setselectedData(undefined);
  
}

 return(
  <Fragment>
    <NavBar openForm={handleFormOpen} />
    <Container style={{marginTop:'7em'}}>
    <UserDashboard  users={data}
    selectedData={selectedData}
    selectActivity={handleSelectedAdtivity}
    cancelselectActivity={handleCancelSelectedAdtivity}
editMode={editMode}
openForm={handleFormOpen}
closeForm={handleFormClose}
createOrEdit={handleCreateOrEditActivity}
    />
    </Container>
   
  </Fragment>
 );
}

export default App
