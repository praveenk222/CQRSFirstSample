import { useEffect, useState } from 'react';
import { Grid, Loader, Segment,Item, Button } from 'semantic-ui-react';

interface Props{
    users:any[];
    selectActivity:(id:string)=>void;

}
export default function UsersList({users,selectActivity}:Props) {
  
    return (
        <Segment>
            <Item.Group divided>
                {users.map(s=>(
                    <Item key={s.Id}>
                        <Item.Content>
                            <Item.Header>
                                <Item.Meta> {s.createdAt}</Item.Meta>
                                <Item.Description> {s.description}</Item.Description>
                            </Item.Header>
                        <Item.Extra>
                            <Button onClick={()=>selectActivity(s.id)}
                            floated='right' content='view' color='blue'></Button>
                        </Item.Extra>
                        </Item.Content>

                    </Item>
                ))}
            </Item.Group>
        </Segment>
    )
}