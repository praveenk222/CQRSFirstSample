import { ChangeEvent, useState } from "react";
import { Button, Form, Segment } from "semantic-ui-react";

interface Props{
    activity:any| undefined;
closeForm:()=> void;
createOrEdit:(activity:any)=> void;

}
export default function AddForm({activity:selectedActivity,closeForm,createOrEdit}:Props) {

    const initialState=selectedActivity ??{
        id:'',
        description: "",
    isActive: true,
    header:'',
    createdAt:''

    }
    function handleSubmit() {
        console.log(activity)
        createOrEdit(activity);
        
    }
    const [activity,setActivity] =useState(initialState);
    function handleInputChange(event:ChangeEvent<HTMLInputElement>) {
        const {name,value}=event.target;
        setActivity({...activity,[name]:value})
    }
    return (
        <Segment clearing>
            <Form>
                <Form.Input  placeholder='Title' value={activity.header} name='header' onChange={handleInputChange}/>
                <Form.Input  placeholder='description' value={activity.description} name='description' onChange={handleInputChange}/>
                <Form.Input  placeholder='createdAt' value={activity.createdAt} name='createdAt' onChange={handleInputChange}/>
                <Button floated="right" positive type="submit" content="Submit"></Button>
                <Button onClick={closeForm} floated="right"  type="button" content="Cancel"></Button>
            </Form>
        </Segment>
    )
}