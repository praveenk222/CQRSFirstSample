import { observer } from 'mobx-react-lite';
import { useEffect, useState } from 'react';
import { Grid, Loader } from 'semantic-ui-react';
import UserList from './UserList';
import UserDetails from './UserDetails';
import AddForm from './forms/AddForm';

interface Props{
    users:any[];
    selectedData:any | undefined;
    selectActivity:(id:string)=>void;
    cancelselectActivity:()=>void;
    editMode:boolean;
openForm:(id:string) => void;
closeForm:()=> void;
createOrEdit:(activity:any) => void;
}
export default observer(function ActivityDashboard({users,selectedData,selectActivity,
    createOrEdit,cancelselectActivity,editMode,openForm,closeForm}:Props) {
    const [loadingNext, setLoadingNext] = useState(false);

    function handleGetNext() {
        setLoadingNext(true);
        
    }
   

    return (
        <Grid>
            <Grid.Column width='10'>
                
                    <UserList users={users}  selectActivity={selectActivity}></UserList>
            </Grid.Column>
            <Grid.Column width='6'>
              {selectedData && !editMode &&
              <UserDetails users={selectedData} cancelselectActivity={cancelselectActivity} 
               openForm={openForm}
              />

             }
             {editMode &&

              <AddForm closeForm={closeForm} activity={selectedData} createOrEdit={createOrEdit} />
             }  
            </Grid.Column>
            {/* <Grid.Column width='10'>
                <Loader active={loadingNext} />
            </Grid.Column> */}
        </Grid>
    )
})