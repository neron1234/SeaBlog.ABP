import Entity from './entity';

export default class blog extends Entity<string>{
    slug!: string;
    title!: string;
    summary!: string;
    content!: string;
    htmlContent!: string;
    isShow!: boolean;
    creationTime!: Date;
}