import {
    CardMeta,
    CardHeader,
    CardDescription,
    CardContent,
    Card,
    Icon,
    Image,
    Button,
  } from 'semantic-ui-react'

  interface Props{
    users:any;
    cancelselectActivity:()=> void;
    openForm:(id:string) => void;
  }
export default function UserDetails({users,cancelselectActivity,openForm}:Props){
    return(

        <Card fluid>
            
    {/* <Image src={'/images/avatar/large/${prop.imgename}`} wrapped ui={false} /> */}
    <Image src='/images/avatar/large/matthew.png' wrapped ui={false} />
    <CardContent>
      <CardHeader>{users.id}</CardHeader>
      <CardMeta>
        <span className='date'>{users.description}</span>
      </CardMeta>
      <CardDescription>
      {users.Description}
      </CardDescription>
    </CardContent>
    <CardContent extra>
      <Button.Group widths='2'>
        <Button basic color='blue' onClick={()=>openForm(users.id)} content='Edit'></Button>
        <Button onClick={cancelselectActivity} basic color='grey' content='Cancel'></Button>
        </Button.Group>
    </CardContent>
  </Card>
    )
}