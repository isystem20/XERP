import React, { Modal } from 'react'


export default class SearchModal extends React.Modal {

    render() {
        return (
            <Modal>
                <div class="table-responsive">
                    <table class="table table-bordered table-striped table-vcenter">
                        <thead>
                            <tr>
                                <th class="text-center" style="width: 100px;">
                                    <i class="far fa-user"></i>
                                </th>
                                <th>Name</th>
                                <th style="width: 30%;">Email</th>
                                <th style="width: 15%;">Access</th>
                                <th class="text-center" style="width: 100px;">Actions</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td class="text-center">
                                    <img class="img-avatar img-avatar48" src="assets/media/avatars/avatar7.jpg" alt=""/>
                                </td>
                                <td class="font-w600 font-size-sm">
                                    <a href="be_pages_generic_profile.html">Laura Carr</a>
                                </td>
                                <td class="font-size-sm">client1<em class="text-muted">@example.com</em></td>
                                <td>
                                    <span class="badge badge-danger">Disabled</span>
                                </td>
                                <td class="text-center">
                                    <div class="btn-group">
                                        <button type="button" class="btn btn-sm btn-primary" data-toggle="tooltip" title="Edit">
                                            <i class="fa fa-fw fa-pencil-alt"></i>
                                        </button>
                                        <button type="button" class="btn btn-sm btn-primary" data-toggle="tooltip" title="Delete">
                                            <i class="fa fa-fw fa-times"></i>
                                        </button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-center">
                                    <img class="img-avatar img-avatar48" src="assets/media/avatars/avatar7.jpg" alt=""/>
                                </td>
                                <td class="font-w600 font-size-sm">
                                    <a href="be_pages_generic_profile.html">Marie Duncan</a>
                                </td>
                                <td class="font-size-sm">client2<em class="text-muted">@example.com</em></td>
                                <td>
                                    <span class="badge badge-primary">Personal</span>
                                </td>
                                <td class="text-center">
                                    <div class="btn-group">
                                        <button type="button" class="btn btn-sm btn-primary" data-toggle="tooltip" title="Edit">
                                            <i class="fa fa-fw fa-pencil-alt"></i>
                                        </button>
                                        <button type="button" class="btn btn-sm btn-primary" data-toggle="tooltip" title="Delete">
                                            <i class="fa fa-fw fa-times"></i>
                                        </button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-center">
                                    <img class="img-avatar img-avatar48" src="assets/media/avatars/avatar2.jpg" alt=""/>
                                </td>
                                <td class="font-w600 font-size-sm">
                                    <a href="be_pages_generic_profile.html">Andrea Gardner</a>
                                </td>
                                <td class="font-size-sm">client3<em class="text-muted">@example.com</em></td>
                                <td>
                                    <span class="badge badge-success">VIP</span>
                                </td>
                                <td class="text-center">
                                    <div class="btn-group">
                                        <button type="button" class="btn btn-sm btn-primary" data-toggle="tooltip" title="Edit">
                                            <i class="fa fa-fw fa-pencil-alt"></i>
                                        </button>
                                        <button type="button" class="btn btn-sm btn-primary" data-toggle="tooltip" title="Delete">
                                            <i class="fa fa-fw fa-times"></i>
                                        </button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-center">
                                    <img class="img-avatar img-avatar48" src="assets/media/avatars/avatar4.jpg" alt=""/>
                                </td>
                                <td class="font-w600 font-size-sm">
                                    <a href="be_pages_generic_profile.html">Amanda Powell</a>
                                </td>
                                <td class="font-size-sm">client4<em class="text-muted">@example.com</em></td>
                                <td>
                                    <span class="badge badge-warning">Trial</span>
                                </td>
                                <td class="text-center">
                                    <div class="btn-group">
                                        <button type="button" class="btn btn-sm btn-primary" data-toggle="tooltip" title="Edit">
                                            <i class="fa fa-fw fa-pencil-alt"></i>
                                        </button>
                                        <button type="button" class="btn btn-sm btn-primary" data-toggle="tooltip" title="Delete">
                                            <i class="fa fa-fw fa-times"></i>
                                        </button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-center">
                                    <img class="img-avatar img-avatar48" src="assets/media/avatars/avatar8.jpg" alt=""/>
                                </td>
                                <td class="font-w600 font-size-sm">
                                    <a href="be_pages_generic_profile.html">Danielle Jones</a>
                                </td>
                                <td class="font-size-sm">client5<em class="text-muted">@example.com</em></td>
                                <td>
                                    <span class="badge badge-primary">Personal</span>
                                </td>
                                <td class="text-center">
                                    <div class="btn-group">
                                        <button type="button" class="btn btn-sm btn-primary" data-toggle="tooltip" title="Edit">
                                            <i class="fa fa-fw fa-pencil-alt"></i>
                                        </button>
                                        <button type="button" class="btn btn-sm btn-primary" data-toggle="tooltip" title="Delete">
                                            <i class="fa fa-fw fa-times"></i>
                                        </button>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class="block-content">
                    <nav aria-label="Page navigation">
                        <ul class="pagination pagination-sm">
                            <li class="page-item">
                                <a class="page-link" href="javascript:void(0)" aria-label="Previous">
                                    <span aria-hidden="true">
                                        <i class="fa fa-angle-left"></i>
                                    </span>
                                    <span class="sr-only">Previous</span>
                                </a>
                            </li>
                            <li class="page-item">
                                <a class="page-link" href="javascript:void(0)">1</a>
                            </li>
                            <li class="page-item">
                                <a class="page-link" href="javascript:void(0)">2</a>
                            </li>
                            <li class="page-item">
                                <a class="page-link" href="javascript:void(0)">3</a>
                            </li>
                            <li class="page-item">
                                <a class="page-link" href="javascript:void(0)">3</a>
                            </li>
                            <li class="page-item">
                                <a class="page-link" href="javascript:void(0)" aria-label="Next">
                                    <span aria-hidden="true">
                                        <i class="fa fa-angle-right"></i>
                                    </span>
                                    <span class="sr-only">Next</span>
                                </a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </Modal>
        );
    }
}